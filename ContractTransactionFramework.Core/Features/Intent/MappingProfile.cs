using AutoMapper;
using ContractTransactionFramework.Features.Intent;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.Intent;

namespace ContractTransactionFramework.Core.Features.Intent;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.Intent, Post>();
        CreateMap<PersistenceModels.Intent, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.Intent, PersistenceModels.Intent>().ReverseMap();
    }
}
