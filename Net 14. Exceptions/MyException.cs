using System.Runtime.Serialization;

namespace Net_14._Exceptions;
/*
 Pravila sozdaniya svoix isklyucheniy:
    - isklyucheniye doljno nasledovatsya ot klassa ApplicationException
    - u isklyucheniya doljen bit ukazan atribut [Serializable]
    - u isklyucheniya doljen bit konstruktor po umolchaniyu
    - u isklyucheniya doljen bit perqrujenniy konstruktor dlya ustonovki svoystva Message
    - u isklyucheniya doljen bit perqrujenniy konstruktor dlya obrobotki vnutrennix isklyucheniy
    - doljen bit konstruktor vipolnyayushiy serializasiyu tipa
 
 */
[Serializable]
public class MyException: ApplicationException
{
    public MyException(){}
    public MyException(string message): base(message) { }
    public MyException(string message, Exception inner): base(message, inner) { }

    protected MyException(SerializationInfo info, StreamingContext context) : base(info, context) { }

}
