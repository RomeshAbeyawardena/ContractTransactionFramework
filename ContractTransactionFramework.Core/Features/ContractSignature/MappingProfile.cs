using AutoMapper;
using ContractTransactionFramework.Features.ContractSignature;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.ContractSignature;

namespace ContractTransactionFramework.Core.Features.ContractSignature;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.ContractSignature, Post>();
        CreateMap<PersistenceModels.ContractSignature, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.ContractSignature, PersistenceModels.ContractSignature>().ReverseMap();
    }
}
