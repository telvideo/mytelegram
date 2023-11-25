﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the bot will receive an <a href="https://corefork.telegram.org/constructor/updateBotShippingQuery">updateBotShippingQuery</a> update. Use this method to reply to shipping queries.
/// <para>Possible errors</para>
/// Code Type Description
/// 400 QUERY_ID_INVALID The query ID is invalid.
/// See <a href="https://corefork.telegram.org/method/messages.setBotShippingResults" />
///</summary>
[TlObject(0xe5f672fa)]
public sealed class RequestSetBotShippingResults : IRequest<IBool>
{
    public uint ConstructorId => 0xe5f672fa;
    ///<summary>
    /// Flags, see <a href="https://corefork.telegram.org/mtproto/TL-combinators#conditional-fields">TL conditional fields</a>
    ///</summary>
    public BitArray Flags { get; set; } = new BitArray(32);

    ///<summary>
    /// Unique identifier for the query to be answered
    ///</summary>
    public long QueryId { get; set; }

    ///<summary>
    /// Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable"). Telegram will display this message to the user.
    ///</summary>
    public string? Error { get; set; }

    ///<summary>
    /// A vector of available shipping options.
    ///</summary>
    public TVector<MyTelegram.Schema.IShippingOption>? ShippingOptions { get; set; }

    public void ComputeFlag()
    {
        if (Error != null) { Flags[0] = true; }
        if (ShippingOptions?.Count > 0) { Flags[1] = true; }
    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Flags);
        writer.Write(QueryId);
        if (Flags[0]) { writer.Write(Error); }
        if (Flags[1]) { writer.Write(ShippingOptions); }
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Flags = reader.ReadBitArray();
        QueryId = reader.ReadInt64();
        if (Flags[0]) { Error = reader.ReadString(); }
        if (Flags[1]) { ShippingOptions = reader.Read<TVector<MyTelegram.Schema.IShippingOption>>(); }
    }
}