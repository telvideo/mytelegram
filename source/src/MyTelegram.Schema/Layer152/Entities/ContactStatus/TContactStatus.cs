﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/contactStatus" />
///</summary>
[TlObject(0x16d9703b)]
public sealed class TContactStatus : IContactStatus
{
    public uint ConstructorId => 0x16d9703b;
    public long UserId { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/UserStatus" />
    ///</summary>
    public MyTelegram.Schema.IUserStatus Status { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(UserId);
        Status.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        UserId = br.ReadInt64();
        Status = br.Deserialize<MyTelegram.Schema.IUserStatus>();
    }
}