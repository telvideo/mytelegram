﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
///See <a href="https://core.telegram.org/method/channels.toggleAntiSpam" />
///</summary>
[TlObject(0x68f3e4eb)]
public sealed class RequestToggleAntiSpam : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x68f3e4eb;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputChannel" />
    ///</summary>
    public MyTelegram.Schema.IInputChannel Channel { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/Bool" />
    ///</summary>
    public bool Enabled { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Channel.Serialize(bw);
        bw.Serialize(Enabled);
    }

    public void Deserialize(BinaryReader br)
    {
        Channel = br.Deserialize<MyTelegram.Schema.IInputChannel>();
        Enabled = br.Deserialize<bool>();
    }
}