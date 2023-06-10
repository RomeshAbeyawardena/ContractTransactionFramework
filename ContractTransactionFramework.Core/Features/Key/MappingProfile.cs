using AutoMapper;
using ContractTransactionFramework.Features.Key;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.Key;

namespace ContractTransactionFramework.Core.Features.Key;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.Key, Post>();
        CreateMap<PersistenceModels.Key, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.Key, PersistenceModels.Key>().ReverseMap();
    }
}
