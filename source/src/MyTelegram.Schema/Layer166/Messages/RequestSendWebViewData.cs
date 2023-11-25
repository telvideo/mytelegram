﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Used by the user to relay data from an opened <a href="https://corefork.telegram.org/api/bots/webapps">reply keyboard bot web app</a> to the bot that owns it.
/// See <a href="https://corefork.telegram.org/method/messages.sendWebViewData" />
///</summary>
[TlObject(0xdc0242c8)]
public sealed class RequestSendWebViewData : IRequest<MyTelegram.Schema.IUpdates>
{
    public uint ConstructorId => 0xdc0242c8;
    ///<summary>
    /// Bot that owns the web app
    /// See <a href="https://corefork.telegram.org/type/InputUser" />
    ///</summary>
    public MyTelegram.Schema.IInputUser Bot { get; set; }

    ///<summary>
    /// Unique client message ID to prevent duplicate sending of the same event
    ///</summary>
    public long RandomId { get; set; }

    ///<summary>
    /// Text of the <a href="https://corefork.telegram.org/constructor/keyboardButtonSimpleWebView">keyboardButtonSimpleWebView</a> that was pressed to open the web app.
    ///</summary>
    public string ButtonText { get; set; }

    ///<summary>
    /// Data to relay to the bot, obtained from a <a href="https://corefork.telegram.org/api/web-events#web-app-data-send"><code>web_app_data_send</code> JS event</a>.
    ///</summary>
    public string Data { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(IBufferWriter<byte> writer)
    {
        ComputeFlag();
        writer.Write(ConstructorId);
        writer.Write(Bot);
        writer.Write(RandomId);
        writer.Write(ButtonText);
        writer.Write(Data);
    }

    public void Deserialize(ref SequenceReader<byte> reader)
    {
        Bot = reader.Read<MyTelegram.Schema.IInputUser>();
        RandomId = reader.ReadInt64();
        ButtonText = reader.ReadString();
        Data = reader.ReadString();
    }
}