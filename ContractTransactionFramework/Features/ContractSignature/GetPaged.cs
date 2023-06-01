﻿using ContractTransactionFramework.Features.ContractSignature;
using MediatR;

namespace ContractTransactionFramework.Features.ContractSignature;

public record GetPaged : IRequest<IEnumerable<Models.ContractSignature>>, IQuery
{
}
