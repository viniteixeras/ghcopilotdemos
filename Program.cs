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
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            background-color: #f0f0f0;
        }
        .container {
            text-align: center;
            background: white;
            padding: 2rem;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
        h1 {
            color: #333;
            font-size: 3rem;
            margin: 0;
        }
        p {
            color: #666;
            font-size: 1.2rem;
            margin-top: 1rem;
        }
        .error-button {
            display: inline-block;
            background: linear-gradient(45deg, #ff6b6b, #ff8e8e);
            color: white;
            padding: 12px 24px;
            border: none;
            border-radius: 8px;
            font-size: 16px;
            font-weight: bold;
            text-decoration: none;
            margin-top: 2rem;
            cursor: pointer;
            box-shadow: 0 4px 6px rgba(255, 107, 107, 0.3);
            transition: all 0.3s ease;
        }
        .error-button:hover {
            background: linear-gradient(45deg, #ff5252, #ff7979);
            box-shadow: 0 6px 8px rgba(255, 107, 107, 0.4);
            transform: translateY(-2px);
        }
        .error-button:active {
            transform: translateY(0);
            box-shadow: 0 2px 4px rgba(255, 107, 107, 0.3);
        }
    </style>
</head>
<body>
    <div class=""container"">
        <h1>Hello, World!</h1>
        <p>Este é um exemplo de página HTML servida por uma aplicação C# web.</p>
        <a href=""/erro"" class=""error-button"">🚨 Gerar Erro</a>
    </div>
</body>
</html>", "text/html"));

// Error route that returns HTTP 400 Bad Request
app.MapGet("/erro", () => Results.BadRequest("Erro HTTP 400 - Bad Request gerado intencionalmente!"));

app.Run();
