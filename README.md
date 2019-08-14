# netcore-grpc-docker-demo
A sample app that demostrates the gRPC on container

# Build it

Do a nuget restore, make sure all the packages are downloaded.

Then use the PowerShell file `ProtoGen.ps1` to generate C# classes for Protocol buffer schema classes.

Now you should be able to compile and build.

# Container

You can build the linux container using the below command:

```
docker build -f .\LinuxDockerfile -t moimhossain/linux-netcore-console-app .
```


Now you have the container, so you can run it as:

```
docker run --network host -it moimhossain/linux-netcore-console-app
```