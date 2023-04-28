﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
///See <a href="https://core.telegram.org/method/help.acceptTermsOfService" />
///</summary>
[TlObject(0xee72f79a)]
public sealed class RequestAcceptTermsOfService : IRequest<IBool>
{
    public uint ConstructorId => 0xee72f79a;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/DataJSON" />
    ///</summary>
    public MyTelegram.Schema.IDataJSON Id { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Id.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Id = br.Deserialize<MyTelegram.Schema.IDataJSON>();
    }
}