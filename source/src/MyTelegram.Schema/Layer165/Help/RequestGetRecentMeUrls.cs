﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// Get recently used <code>t.me</code> links.When installing official applications from "Download Telegram" buttons present in <a href="https://t.me/">t.me</a> pages, a referral parameter is passed to applications after installation.<br>
/// If, after downloading the application, the user creates a new account (instead of logging into an existing one), the referral parameter should be imported using this method, which returns the <a href="https://t.me/">t.me</a> pages the user recently opened, before installing Telegram.
/// See <a href="https://corefork.telegram.org/method/help.getRecentMeUrls" />
///</summary>
[TlObject(0x3dc0f114)]
public sealed class RequestGetRecentMeUrls : IRequest<MyTelegram.Schema.Help.IRecentMeUrls>
{
    public uint ConstructorId => 0x3dc0f114;
    ///<summary>
    /// Referrer
    ///</summary>
    public string Referer { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Referer);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Referer = reader.ReadString();
    }
}