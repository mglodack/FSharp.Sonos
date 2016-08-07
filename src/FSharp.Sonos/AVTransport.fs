namespace FSharp.UPnP

module AVTransport =
  open FSharp.UPnP.Exceptions

  let ServiceIdentifier = "urn:schemas-upnp-org:service:"
  let ServiceType = "AVTransport:1"

  type Action =
  | Play
  | Pause

  let convertActionToString action =
    match action with
    | Play  -> "#Play"
    | Pause -> "#Pause"

  type InstanceID = InstanceID of int

  let pause (instanceId : InstanceID) =
    match instanceId with
    | InstanceID id -> id
    | _             -> raise (GenericException "TODO: PLEASE FIX ME :)")

