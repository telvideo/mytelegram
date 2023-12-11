﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Contacts;

///<summary>
/// Obtain user info from a <a href="https://corefork.telegram.org/api/links#temporary-profile-links">temporary profile link</a>.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 IMPORT_TOKEN_INVALID The specified token is invalid.
/// See <a href="https://corefork.telegram.org/method/contacts.importContactToken" />
///</summary>
[TlObject(0x13005788)]
public sealed class RequestImportContactToken : IRequest<MyTelegram.Schema.IUser>
{
    public uint ConstructorId => 0x13005788;
    ///<summary>
    /// The token extracted from the <a href="https://corefork.telegram.org/api/links#temporary-profile-links">temporary profile link</a>.
    ///</summary>
    public string Token { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Token);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Token = reader.ReadString();
    }
}