# quartz-windows-service

This project is my skeleton project to build jobs using `Quartz` and creating windows service using `Topshelf`

## Requirements
- .NET Framework 4.7.2

## Notes
- `~/Config/Quartz.Service.Jobs.xml`: The jobs are configured here.
- Quartz configuration is on `App.config` file inside `<quartz>` tag.
- You can use your favorites logger and DI framework.

## Instructions
- `~/Quartz.Service.exe install`: Create windows service
- `~/Quartz.Service.exe uninstall`: Remove windows service

## References
- [Quartz.NET](https://www.quartz-scheduler.net/)
- [Topshelf](http://topshelf-project.com/)
