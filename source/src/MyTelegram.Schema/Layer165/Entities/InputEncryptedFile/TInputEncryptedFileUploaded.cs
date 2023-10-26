﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Sets new encrypted file saved by parts using upload.saveFilePart method.
/// See <a href="https://corefork.telegram.org/constructor/inputEncryptedFileUploaded" />
///</summary>
[TlObject(0x64bd0306)]
public sealed class TInputEncryptedFileUploaded : IInputEncryptedFile
{
    public uint ConstructorId => 0x64bd0306;
    ///<summary>
    /// Random file ID created by client
    ///</summary>
    public long Id { get; set; }

    ///<summary>
    /// Number of saved parts
    ///</summary>
    public int Parts { get; set; }

    ///<summary>
    /// In case <a href="https://en.wikipedia.org/wiki/MD5">md5-HASH</a> of the (already encrypted) file was transmitted, file content will be checked prior to use
    ///</summary>
    public string Md5Checksum { get; set; }

    ///<summary>
    /// 32-bit fingerprint of the key used to encrypt a file
    ///</summary>
    public int KeyFingerprint { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Id);
        writer.Write(Parts);
        writer.Write(Md5Checksum);
        writer.Write(KeyFingerprint);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Id = reader.ReadInt64();
        Parts = reader.ReadInt32();
        Md5Checksum = reader.ReadString();
        KeyFingerprint = reader.ReadInt32();
    }
}