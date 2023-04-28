﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
///See <a href="https://core.telegram.org/method/help.dismissSuggestion" />
///</summary>
[TlObject(0xf50dbaa1)]
public sealed class RequestDismissSuggestion : IRequest<IBool>
{
    public uint ConstructorId => 0xf50dbaa1;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPeer" />
    ///</summary>
    public MyTelegram.Schema.IInputPeer Peer { get; set; }
    public string Suggestion { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        bw.Serialize(Suggestion);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IInputPeer>();
        Suggestion = br.Deserialize<string>();
    }
}