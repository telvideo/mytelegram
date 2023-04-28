﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
///See <a href="https://core.telegram.org/method/channels.viewSponsoredMessage" />
///</summary>
[TlObject(0xbeaedb94)]
public sealed class RequestViewSponsoredMessage : IRequest<IBool>
{
    public uint ConstructorId => 0xbeaedb94;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }
    public byte[] RandomId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Channel.Serialize(bw);
        bw.Serialize(RandomId);
    }

    public void Deserialize(BinaryReader br)
    {
        Channel = br.Deserialize<MyTelegram.Schema.IInputChannel>();
        RandomId = br.Deserialize<byte[]>();
    }
}