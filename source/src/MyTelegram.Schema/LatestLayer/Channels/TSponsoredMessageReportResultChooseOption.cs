﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Channels;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/channels.sponsoredMessageReportResultChooseOption" />
///</summary>
[TlObject(0x846f9e42)]
public sealed class TSponsoredMessageReportResultChooseOption : ISponsoredMessageReportResult
{
    public uint ConstructorId => 0x846f9e42;
    public string Title { get; set; }
    public TVector<MyTelegram.Schema.ISponsoredMessageReportOption> Options { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Title);
        writer.Write(Options);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Title = reader.ReadString();
        Options = reader.Read<TVector<MyTelegram.Schema.ISponsoredMessageReportOption>>();
    }
}