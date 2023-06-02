﻿using ContractTransactionFramework.Persistence.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Persistence.Core.Features.ContractSignature;

public class GetPagedHandler : IRequestHandler<GetPaged, IEnumerable<Models.ContractSignature>>
{
    public Task<IEnumerable<Models.ContractSignature>> Handle(GetPaged request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}