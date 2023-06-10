using AutoMapper;
using ContractTransactionFramework.Features.TransactionLedger;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.TransactionLedger;

namespace ContractTransactionFramework.Core.Features.TransactionLedger;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.TransactionLedger, Post>();
        CreateMap<PersistenceModels.TransactionLedger, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.TransactionLedger, PersistenceModels.TransactionLedger>().ReverseMap();
    }
}
