using AutoMapper;
using ContractTransactionFramework.Features.TransactionLedgerHash;
using PersistenceModels = ContractTransactionFramework.Persistence.Models;
using PersistenceFeature = ContractTransactionFramework.Persistence.Features.TransactionLedgerHash;


namespace ContractTransactionFramework.Core.Features.TransactionLedgerHash;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Get, PersistenceFeature.Get>();
        CreateMap<GetPaged, PersistenceFeature.GetPaged>();
        CreateMap<PersistenceModels.TransactionLedgerHash, Post>();
        CreateMap<PersistenceModels.TransactionLedgerHash, Put>();
        CreateMap<Post, PersistenceFeature.Post>();
        CreateMap<Put, PersistenceFeature.Put>();
        CreateMap<Models.TransactionLedgerHash, PersistenceModels.TransactionLedgerHash>()
            .ReverseMap();
    }
}
