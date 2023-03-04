﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/secureSecretSettings" />
///</summary>
[TlObject(0x1527bcac)]
public sealed class TSecureSecretSettings : ISecureSecretSettings
{
    public uint ConstructorId => 0x1527bcac;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/SecurePasswordKdfAlgo" />
    ///</summary>
    public MyTelegram.Schema.ISecurePasswordKdfAlgo SecureAlgo { get; set; }
    public byte[] SecureSecret { get; set; }
    public long SecureSecretId { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        SecureAlgo.Serialize(bw);
        bw.Serialize(SecureSecret);
        bw.Write(SecureSecretId);
    }

    public void Deserialize(BinaryReader br)
    {
        SecureAlgo = br.Deserialize<MyTelegram.Schema.ISecurePasswordKdfAlgo>();
        SecureSecret = br.Deserialize<byte[]>();
        SecureSecretId = br.ReadInt64();
    }
}