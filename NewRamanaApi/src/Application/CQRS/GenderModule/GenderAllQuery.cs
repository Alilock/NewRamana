using Application.DbContext;
using Domain.Entities;
using Domain.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.GenderModule
{
    public class GenderAllQuery :IRequest<ICollection<Gender>>
    {
        public class GenderAllQueryHandler : IRequestHandler<GenderAllQuery, ICollection<Gender>>
        {
            private readonly AppDbContext db;

            public GenderAllQueryHandler(AppDbContext db)
            {
                this.db = db;
            }

            public async Task<ICollection<Gender>> Handle(GenderAllQuery request, CancellationToken cancellationToken)
            {
                var data = await db.Genders.Where(g=>g.DeletedDate==null).ToListAsync(cancellationToken);
                var response= new Response<Gender>();
                return data.ToList();

            }
        }
    }
}
