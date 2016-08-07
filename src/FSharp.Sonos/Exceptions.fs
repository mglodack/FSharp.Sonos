namespace FSharp.UPnP

module Exceptions =
  type Error =
    {
      ErrorCode : int;
      ErrorDescription : string;
      Description : string
    }
  exception GenericException of string
  exception AVTransportException of Error

