# 🚀 GitHub Portfolio & Search Engine

פרויקט Fullstack המציג פורטפוליו אישי מ-GitHub ומאפשר חיפוש פרויקטים גלובלי, תוך שימוש ב-API של GitHub.

## 🛠 טכנולוגיות
- **Backend:** .NET 8 Web API
- **Client Library:** Octokit (GitHub API Client)
- **Frontend:** HTML5, CSS3, JavaScript (Vanilla)
- **Performance:** In-Memory Caching
- **Security:** User Secrets for API Authentication

## ✨ תכונות עיקריות
- **Personal Portfolio:** שליפת כל ה-Repositories האישיים, כולל כמות כוכבים, שפת פיתוח וכמות Pull Requests.
- **Global Search:** חיפוש פרויקטים בכל GitHub לפי שם, שפת פיתוח ושם משתמש.
- **Smart Caching:** המערכת שומרת את הנתונים בזיכרון ל-5 דקות כדי לשפר ביצועים ולמנוע חריגה ממכסות ה-API.
- **Clean Architecture:** הפרדה בין שכבת השירות (Service) לשכבת ה-API.

## 🚀 איך להריץ את הפרויקט?
1. יש לשכפל את המאגר (Clone).
2. יש להנפיק **GitHub Personal Access Token**.
3. יש להוסיף את הטוקן ל-**User Secrets** של הפרויקט תחת המפתח `GitHubSettings:ApiToken`.
4. להריץ את ה-Solution ב-Visual Studio.
