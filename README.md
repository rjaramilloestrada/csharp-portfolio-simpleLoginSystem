# Simple Login System

C# console application demonstrating user authentication and file-based data storage.

## Features
- User registration
- Login authentication
- Password hashing
- Session management
- File-based storage

## Technical Implementation
```csharp
public class LoginSystem
{
    private Dictionary<string, string> users = new();
    
    public bool Authenticate(string username, string password)
    {
        if (!users.ContainsKey(username)) return false;
        return VerifyHash(password, users[username]);
    }
    
    private string HashPassword(string password)
    {
        // Implementation of secure hashing
    }
}
```

## Project Structure
```
SimpleLoginSystem/
├── Program.cs
├── LoginSystem.cs
├── UserManager.cs
├── Security/
│   └── Hash.cs
└── Data/
    └── users.txt
```

## Security Features
- Password hashing
- Input validation
- Basic brute force protection
- Secure file operations

## Future Enhancements
- Database integration
- Password recovery
- Two-factor authentication
- Role-based access

## License
MIT License
