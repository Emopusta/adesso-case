using Application.Features.Teams.Queries.GetList;
using Application.Services.Repositories;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistence.Paging;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Teams.Queries.GetAllSeparatedByGroupId
{
    public class GetAllSeparatedByGroupIdQuery : IRequest<GetListResponse<GetAllSeparatedByGroupIdDto>>
    {
        public class GetAllSeparatedByGroupIdQueryHandler : IRequestHandler<GetAllSeparatedByGroupIdQuery, GetListResponse<GetAllSeparatedByGroupIdDto>>
        {
            private readonly ITeamRepository _teamRepository;
            private readonly IMapper _mapper;

            public GetAllSeparatedByGroupIdQueryHandler(ITeamRepository teamRepository, IMapper mapper)
            {
                _teamRepository = teamRepository;
                _mapper = mapper;
            }

            public async Task<GetListResponse<GetAllSeparatedByGroupIdDto>> Handle(GetAllSeparatedByGroupIdQuery request, CancellationToken cancellationToken)
            {
                IPaginate<Team> teams = await _teamRepository.GetListAsync(
                    include: t => t.Include(t => t.Group).Include(t => t.Country),
                    index: 0,
                    size: 32,
                    cancellationToken: cancellationToken
                );



                GetListResponse<GetAllSeparatedByGroupIdDto> response = _mapper.Map<GetListResponse<GetAllSeparatedByGroupIdDto>>(teams);
                return response;
            }
        }
    }
}
