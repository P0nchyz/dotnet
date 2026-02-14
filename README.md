# Projects

1. Task Manager (Console)
2. Recipe Book (WPF Desktop)
3. Fitness Tracker (MAUI Mobile)
4. Blog API (ASP.Net Core)

## Project 1: Personal Task Manager (Console Application)

Build a console application to manage daily tasks with categories, priorities, and due dates.

### Features

- Menu System
	1. Add Task
	2. View All Tasks
	3. View Tasks by Category
	4. Mark Task Complete
	5. Delete Task
	6. Exit
	7. Search Tasks
	8. View Overdue Tasks
	9. View Completed Tasks
	10. Edit Task
	11. Export Tasks to File
	12. Import Tasks from File
	13. Statistics (total tasks, completion rate, etc.)

- Task Properties
	- Title
	- Description
	- Category (Work, Personal, Shopping, etc.)
	- Priority (Low, Medium, High)
	- Due Date
	- Status (Pending, Complete)

### Success Criteria

- Application runs without crashes
- Task persist between sessions
- Can perform all CRUD operations
- Code is organized into logical classes
- Proper error messages for invalid input

## Project 2: Recipe Book (WPF Desktop Application)

Build a desktop application to manage recipes with ingredients, instructions, categories and photos.

### Features

- Main Window
	- Recipe List
	- Recipe Detail View (Main Area)
	- Add/Edit/Delete buttons
	- Search Bar

- Recipe Properties
	- Name
	- Category (Breakfast, Luch, Dinner, Dessert)
	- Prep Time
	- Cook Time
	- Servings
	- Difficulty
	- Ingredients (List)
	- Instrunctions (Numbered)
	- Photo (optional)

- Features
	- Save Recipe to SQLite database
	- Category Filtering
	- Tag System (vegetarian, gluten-free, etc,)
	- Favorite Recipes
	- Recipe Scaling (adjust servings -> auto-Scale ingredients)
	- Print Recipe
	- Shopping List Generation
	- Recipe Import/Export (JSON)
	- Image Upload and Display
	- Nutrition Information
	- Cooking Timer
	- Search with Multiple Filters
	- Recent Recipes List
	- Recipe Rating System

### Success Criteria

- Application uses MVVM pattern correctly
- Data persists in SQLite database
- UI is responsive and intuitive
- No code-behind in views (except minimal event handlers)
- Can filter, search and sort recipes
- ObservableCollection updates UI automatically

## Project 3: Fitness Tracker (MAUI Mobile App)

Build a mobile fitness tracking app to log workouts, track progress with photos, and view statistics.

### Features

- Screens
	1. Login/Profile Setup
	2. Workout List (history)
	3. Add Workout
	4. Workout Detail

- Workout Properies
	- Date & Time
	- Exerciste Type (Cardio, Strenght, Yoga, etc.)
	- Duration
	- Calories
	- Notes
	- Difficulty Rating

- Features
	- Progress Photo Capture
	- Photo Gallery View
	- Before/After Comparisons
	- Body Measurements Tracking
	- Weight Tracking with Graph
	- Personal Records
	- Weekly/Monthly Statistics
	- Charts (Workout Frequency, Calories Burned, etc.)
	- Goal Settings (weekly workout target)
	- Streak Tracking
	- Achievement Badges
	- Export Workout Data

- Mobile Navigation
	- Tabbed Pages
	- Flyout Menu
	- Route-base Navigation
	- Passing Parameter between Pages
	- Touch Gestures
	- Pull to Refresh
	- Swipe Actions (delete, edit, etc.)
	- Modal Sheets
	- Botton Navigation
	- Mobile-friendly Forms

- Camera Integration
	- Permission Handling
	- Camera Capture
	- Photo Gallery Access
	- Image Compresion
	- Local File Storage
	- Thumbnail Generation

- Offline-First Desing
	1. All data stored locally (SQLite)
	2. App works 100% offline
	3. No cloud sync
	4. Fast, responsive UI

### Success Criteria

- App runs smoothly on Android device/emulator
- Can capture and display photos
- All data persist locally
- Navigation is intuitive
- Handles permissions correctly
- UI follows mobile best practices
- No crashes or freezes

## Project 4: Blog API (ASP.NET Core Web API)

Build a RESTful API for a blogging platform with user authentication, post, comments, categories, and image uploads.

### Features

- Endpoints

```
POST   /api/auth/register
POST   /api/auth/login
GET    /api/posts
GET    /api/posts/{id}
POST   /api/posts (authenticated)
PUT    /api/posts/{id} (authenticated, owner only)
DELETE /api/posts/{id} (authenticated, owner only)
POST   /api/posts/{id}/images (file upload)
GET    /api/users/{id}/posts
GET    /api/posts/{id}/comments
POST   /api/posts/{id}/comments (authenticated)
DELETE /api/comments/{id} (authenticated, owner only)
GET    /api/categories
GET    /api/categories/{id}/posts
```

- Models
	- User (Id, Username, Email, PasswordHash)
	- Post (Id, Title, Content, AuthorId, CreatedDate, UpdatedDate)
	- Comment (Id, PostId, UserId, Content, CreatedDate)
	- Category (Id, Name, Slug) // Search Category Slug
	- PostCategory (many-to-many relationship)

- Features
	- Pagination (posts, comments)
	- Filtering (by category, author, date range)
	- Sorting (newest, popular, etc.)
	- Search (post title/content)
	- Rate Limiting
	- Caching (in-memory)
	- API Versioning (v1, v2)
	- Comprehensive Loging (Serilog)
	- Unit Tests for Services
	- Integration Tests for Endpoints

- Authentication & Authorization
	- JWT token generation
	- Password hashing (BCrypt)
	- Token Validation Middleware
	- Role-based Authorization
	- Owner-based authorization

- Security
	- HTTPS Only
	- CORS Configuration
	- Input Validation
	- SQL Injection Prevention (EF Core Handlers)
	- XSS Prevention

### Success Criteria

- All CRUD endpoint working
- JWT authentication implemented
- Proper authorization checks
- File uploads functioning
- Swagger documentation complete
- Error handling consistent
- Database relationship correct
- At least basic unit tests
- API follows REST principles
- Can be tested with Postman/cURL