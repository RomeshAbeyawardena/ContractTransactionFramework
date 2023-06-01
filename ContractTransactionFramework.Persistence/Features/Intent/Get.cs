﻿using ContractTransactionFramework.Features.Intent;
using MediatR;

namespace ContractTransactionFramework.Persistence.Features.Intent;

public record Get : IRequest<IEnumerable<Models.Intent>>, IQuery
{
}
