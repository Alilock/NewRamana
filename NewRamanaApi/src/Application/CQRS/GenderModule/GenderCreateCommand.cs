using Domain.Entities;
using Domain.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.CQRS.GenderModule
{
    public class GenderCreateCommand :IRequest<ResponseCreate<Gender>>

    {
        public string? Name { get; set; }
        //public class GenderCreateCommandHandler : IRequestHandler<GenderCreateCommand, ResponseCreate<Gender>>
        //{
        //    public Task<ResponseCreate<Gender>> Handle(GenderCreateCommand request, CancellationToken cancellationToken)
        //    {
                
        //    }
        //}
    }
}
