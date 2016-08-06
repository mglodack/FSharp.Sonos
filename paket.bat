@echo off

set paket_args=%*

:: Bootstrap Paket if we don't have a copy locally
IF NOT EXIST .paket\paket.exe (
  .paket\paket.bootstrapper.exe
)

:: Execute whatever Paket command we were given
.paket\paket.exe %paket_args%
