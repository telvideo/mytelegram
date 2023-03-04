﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Account;


///<summary>
///See <a href="https://core.telegram.org/constructor/account.authorizationForm" />
///</summary>
[TlObject(0xad2e1cd8)]
public sealed class TAuthorizationForm : IAuthorizationForm
{
    public uint ConstructorId => 0xad2e1cd8;
    public BitArray Flags { get; set; } = new BitArray(32);
    public TVector<MyTelegram.Schema.ISecureRequiredType> RequiredTypes { get; set; }
    public TVector<MyTelegram.Schema.ISecureValue> Values { get; set; }
    public TVector<MyTelegram.Schema.ISecureValueError> Errors { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }
    public string? PrivacyPolicyUrl { get; set; }

    public void ComputeFlag()
    {
        if (PrivacyPolicyUrl != null) { Flags[0] = true; }
    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(Flags);
        RequiredTypes.Serialize(bw);
        Values.Serialize(bw);
        Errors.Serialize(bw);
        Users.Serialize(bw);
        if (Flags[0]) { bw.Serialize(PrivacyPolicyUrl); }
    }

    public void Deserialize(BinaryReader br)
    {
        Flags = br.Deserialize<BitArray>();
        RequiredTypes = br.Deserialize<TVector<MyTelegram.Schema.ISecureRequiredType>>();
        Values = br.Deserialize<TVector<MyTelegram.Schema.ISecureValue>>();
        Errors = br.Deserialize<TVector<MyTelegram.Schema.ISecureValueError>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
        if (Flags[0]) { PrivacyPolicyUrl = br.Deserialize<string>(); }
    }
}