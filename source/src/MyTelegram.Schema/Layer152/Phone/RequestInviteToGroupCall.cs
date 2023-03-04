﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
///See <a href="https://core.telegram.org/method/phone.inviteToGroupCall" />
///</summary>
[TlObject(0x7b393160)]
public sealed class RequestInviteToGroupCall : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x7b393160;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/InputGroupCall" />
    ///</summary>
    public MyTelegram.Schema.IInputGroupCall Call { get; set; }
    public TVector<MyTelegram.Schema.IInputUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Call.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Call = br.Deserialize<MyTelegram.Schema.IInputGroupCall>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IInputUser>>();
    }
}