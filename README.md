StandardAbstraction
-------------------

StandardAbstraction provides wrapper interfaces around .NET framework classes which interact with the operating system (e.g. classes in the System.IO.File and System.Net.Sockets namespaces).  This allows for mocking of these classes in unit tests.

The project is a .NET Standard-compatible version of [FrameworkAbstraction](https://github.com/alastairwyse/FrameworkAbstraction).  Some wrapper interfaces from FrameworkAbstraction which are not compatible with .NET Standard will remain in FrameworkAbstraction (i.e. are not included in this project).

#### Release History

<table>
  <tr>
    <td><b>Version</b></td>
    <td><b>Changes</b></td>
  </tr>
  <tr>
    <td valign="top">1.2.0</td>
    <td>
      Added System.Diagnostics.Stopwatch.Frequency property
    </td>
  </tr>
  <tr>
    <td valign="top">1.1.0</td>
    <td>
      Added abstraction for System.Diagnostics.Stopwatch
    </td>
  </tr>
  <tr>
    <td valign="top">1.0.0</td>
    <td>
      Initial version forked/migrated from <a href="https://github.com/alastairwyse/FrameworkAbstraction">FrameworkAbstraction</a>
    </td>
  </tr>
</table>