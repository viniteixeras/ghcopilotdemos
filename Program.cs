// Web application that serves HTML Hello World
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configure the HTTP request pipeline
app.MapGet("/", () => Results.Content(@"
<!DOCTYPE html>
<html lang=""pt-BR"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Hello World</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            background-color: #f0f0f0;
            transition: background-color 0.3s ease;
        }
        body.dark-theme {
            background-color: #000000;
        }
        .container {
            text-align: center;
            background: white;
            padding: 2rem;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
            transition: background-color 0.3s ease, color 0.3s ease, box-shadow 0.3s ease;
        }
        .dark-theme .container {
            background: #333;
            color: white;
            box-shadow: 0 4px 6px rgba(255, 255, 255, 0.1);
        }
        h1 {
            color: #333;
            font-size: 3rem;
            margin: 0;
            transition: color 0.3s ease;
        }
        .dark-theme h1 {
            color: #fff;
        }
        p {
            color: #666;
            font-size: 1.2rem;
            margin-top: 1rem;
            transition: color 0.3s ease;
        }
        .dark-theme p {
            color: #ccc;
        }
        .toggle-button {
            margin-top: 2rem;
            padding: 0.75rem 1.5rem;
            font-size: 1rem;
            border: 2px solid #333;
            background: white;
            color: #333;
            border-radius: 5px;
            cursor: pointer;
            transition: all 0.3s ease;
        }
        .toggle-button:hover {
            background: #333;
            color: white;
        }
        .dark-theme .toggle-button {
            border-color: #fff;
            background: #333;
            color: #fff;
        }
        .dark-theme .toggle-button:hover {
            background: #fff;
            color: #333;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <h1>Hello, World!</h1>
        <p>Este é um exemplo de página HTML servida por uma aplicação C# web.</p>
        <button class=""toggle-button"" onclick=""toggleTheme()"">Alternar Tema</button>
    </div>
    <script>
        function toggleTheme() {
            const body = document.body;
            body.classList.toggle('dark-theme');
        }
    </script>
</body>
</html>", "text/html"));

app.Run();
