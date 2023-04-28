﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
///See <a href="https://core.telegram.org/method/phone.saveCallDebug" />
///</summary>
[TlObject(0x277add7e)]
public sealed class RequestSaveCallDebug : IRequest<IBool>
{
    public uint ConstructorId => 0x277add7e;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputPhoneCall" />
    ///</summary>
    public MyTelegram.Schema.IInputPhoneCall Peer { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON Debug { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Peer.Serialize(bw);
        Debug.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Peer = br.Deserialize<MyTelegram.Schema.IInputPhoneCall>();
        Debug = br.Deserialize<MyTelegram.Schema.IDataJSON>();
    }
}