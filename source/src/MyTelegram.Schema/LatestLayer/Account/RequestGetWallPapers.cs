﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;

///<summary>
/// Returns a list of available <a href="https://corefork.telegram.org/api/wallpapers">wallpapers</a>.
/// See <a href="https://corefork.telegram.org/method/account.getWallPapers" />
///</summary>
[TlObject(0x7967d36)]
public sealed class RequestGetWallPapers : IRequest<MyTelegram.Schema.Account.IWallPapers>
{
    public uint ConstructorId => 0x7967d36;
    ///<summary>
    /// <a href="https://corefork.telegram.org/api/offsets#hash-generation">Hash for pagination, for more info click here</a>
    ///</summary>
    public long Hash { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Hash);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Hash = reader.ReadInt64();
    }
}