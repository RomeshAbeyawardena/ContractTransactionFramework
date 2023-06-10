using AutoMapper;
using ContractTransactionFramework.Features.Transaction;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.Transaction;

namespace ContractTransactionFramework.Core.Features.Transaction;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.Transaction, Post>();
        CreateMap<PersistenceModels.Transaction, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.Transaction, PersistenceModels.Transaction>().ReverseMap();
    }
}
