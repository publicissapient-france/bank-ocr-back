Back BankOCR pour la Xebicon19

Lancer bankocr.service

    dotnet run

Le service se lance par défaut sur le port 5000 en http et 5001 en https

Appeler l'URL : https://localhost:5001/api/ocr
Avec le fichier contenant le text à convertir en form-data. Le nom de la clé est "file"
