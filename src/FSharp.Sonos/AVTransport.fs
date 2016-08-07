namespace FSharp.UPnP

// Documentation found here: http://upnp.org/specs/av/UPnP-av-AVTransport-v1-Service.pdf
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

  type InstanceId = InstanceId of int
  type Speed = Speed of int

  let desctructureInstanceId instanceId =
    match instanceId with
    | InstanceId id -> id

  let pause (instanceId : InstanceId) =


  let play (instanceId : InstanceId) (speed : Speed)  =

