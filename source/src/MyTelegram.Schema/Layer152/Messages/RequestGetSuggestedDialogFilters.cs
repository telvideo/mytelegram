﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
///See <a href="https://core.telegram.org/method/messages.getSuggestedDialogFilters" />
///</summary>
[TlObject(0xa29cd42c)]
public sealed class RequestGetSuggestedDialogFilters : IRequest<TVector<MyTelegram.Schema.IDialogFilterSuggested>>
{
    public uint ConstructorId => 0xa29cd42c;

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}