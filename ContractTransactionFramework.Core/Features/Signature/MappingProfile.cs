using AutoMapper;
using ContractTransactionFramework.Features.Signature;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.Signature;

namespace ContractTransactionFramework.Core.Features.Signature;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.Signature, Post>();
        CreateMap<PersistenceModels.Signature, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.Signature, PersistenceModels.Signature>().ReverseMap();
    }
}
