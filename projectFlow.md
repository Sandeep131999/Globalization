LANGUAGECHANGE/
├── Controllers/
│   ├── HomeController.cs        <!-- Handles language change requests -->
├── Models/
│   ├── ErrorViewModel.cs        <!-- ViewModel for error handling -->
├── Resources/                   <!-- Resource files for language support -->
│   ├── Label.en-IN.resx         <!-- Resource file for English (India) labels -->
│   ├── Label.en-US.resx         <!-- Resource file for English (US) labels -->
│   ├── Label.ja-JP.resx         <!-- Resource file for Japanese (Japan) labels -->
│   ├── Message.en-IN.resx       <!-- Resource file for English (India) messages -->
│   ├── Message.en-US.resx       <!-- Resource file for English (US) messages -->
│   ├── Message.ja-JP.resx       <!-- Resource file for Japanese (Japan) messages -->
├── Services/
│   ├── SharedResourceService.cs <!-- Service for shared resource localization -->
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml          <!-- Home page view -->
│   │   ├── About.cshtml          <!-- About page view -->
│   │   ├── Register.cshtml       <!-- Registration page view -->
│   └── Shared/
│       ├── _Layout.cshtml        <!-- Main layout view -->
│       ├── _Layout.cshtml.css    <!-- Stylesheet for the main layout -->
│       ├── _ValidationScriptsPartial.cshtml <!-- Partial view for validation scripts -->
│       └── Error.cshtml          <!-- Error page view -->
│   ├── _ViewImports.cshtml       <!-- Imports necessary namespaces and services for localization and tag helpers -->
│   ├── _ViewStart.cshtml         <!-- Sets up the default layout view -->
├── wwwroot/
│   ├── css/
│   │   ├── site.css              <!-- Main site stylesheet -->
│   ├── js/
│   │   ├── site.js               <!-- Main site JavaScript file -->
│   └── lib/
│       ├── bootstrap/            <!-- Bootstrap library -->
│       ├── jquery/               <!-- jQuery library -->
│       └── ...                   <!-- Other libraries -->
├── .gitignore                    <!-- Specifies files and directories to ignore in Git -->
├── appsettings.Development.json  <!-- Configuration settings for the development environment -->
├── appsettings.json              <!-- Configuration settings for the application -->
├── GlobalUsings.cs               <!-- Global using directives -->
├── Label.cs                      <!-- Label resource class for strongly-typed access to resources -->
├── Message.cs                    <!-- Message resource class for strongly-typed access to resources -->
├── Program.cs                    <!-- Configures and runs the application -->
└── Try.csproj                    <!-- Project file for the application -->
