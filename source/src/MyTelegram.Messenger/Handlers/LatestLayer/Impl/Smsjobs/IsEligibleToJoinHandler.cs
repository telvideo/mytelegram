﻿// ReSharper disable All

namespace MyTelegram.Handlers.Smsjobs;

///<summary>
/// See <a href="https://corefork.telegram.org/method/smsjobs.isEligibleToJoin" />
///</summary>
internal sealed class IsEligibleToJoinHandler : RpcResultObjectHandler<MyTelegram.Schema.Smsjobs.RequestIsEligibleToJoin, MyTelegram.Schema.Smsjobs.IEligibilityToJoin>,
    Smsjobs.IIsEligibleToJoinHandler
{
    protected override Task<MyTelegram.Schema.Smsjobs.IEligibilityToJoin> HandleCoreAsync(IRequestInput input,
        MyTelegram.Schema.Smsjobs.RequestIsEligibleToJoin obj)
    {
        throw new NotImplementedException();
    }
}
