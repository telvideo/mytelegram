﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contact status: online / offline.
/// See <a href="https://corefork.telegram.org/constructor/contactStatus" />
///</summary>
[TlObject(0x16d9703b)]
public sealed class TContactStatus : IContactStatus
{
    public uint ConstructorId => 0x16d9703b;
    ///<summary>
    /// User identifier
    ///</summary>
    public long UserId { get; set; }

    ///<summary>
    /// Online status
    /// See <a href="https://corefork.telegram.org/type/UserStatus" />
    ///</summary>
    public MyTelegram.Schema.IUserStatus Status { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(UserId);
        writer.Write(Status);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        UserId = reader.ReadInt64();
        Status = reader.Read<MyTelegram.Schema.IUserStatus>();
    }
}