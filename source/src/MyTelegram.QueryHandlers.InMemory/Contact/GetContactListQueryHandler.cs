﻿namespace MyTelegram.QueryHandlers.InMemory.Contact;

public class GetContactListQueryHandler(IQueryOnlyReadModelStore<ContactReadModel> store) : IQueryHandler<GetContactListQuery, IReadOnlyCollection<IContactReadModel>>
{
    public async Task<IReadOnlyCollection<IContactReadModel>> ExecuteQueryAsync(GetContactListQuery query,
        CancellationToken cancellationToken)
    {
        var idList = query.TargetUserIdList.Select(p => ContactId.Create(query.SelfUserId, p).Value).ToList();
        return await store.FindAsync(p => idList.Contains(p.Id), cancellationToken: cancellationToken);
    }
}