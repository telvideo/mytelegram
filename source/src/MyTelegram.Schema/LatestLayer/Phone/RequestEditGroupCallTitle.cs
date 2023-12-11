﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Phone;

///<summary>
/// Edit the title of a group call or livestream
/// <para>Possible errors</para>
/// Code Type Description
/// 403 GROUPCALL_FORBIDDEN The group call has already ended.
/// See <a href="https://corefork.telegram.org/method/phone.editGroupCallTitle" />
///</summary>
[TlObject(0x1ca6ac0a)]
public sealed class RequestEditGroupCallTitle : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0x1ca6ac0a;
    ///<summary>
    /// Group call
    /// See <a href="https://corefork.telegram.org/type/InputGroupCall" />
    ///</summary>
    public MyTelegram.Schema.IInputGroupCall Call { get; set; }

    ///<summary>
    /// New title
    ///</summary>
    public string Title { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Call);
        writer.Write(Title);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Call = reader.Read<MyTelegram.Schema.IInputGroupCall>();
        Title = reader.ReadString();
    }
}