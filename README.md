# CloudQA Internship - Automation Form Test with Selenium (C#)

## Overview
This project is a C# Selenium automation script that fills out four fields on the [CloudQA Automation Practice Form](https://app.cloudqa.io/home/AutomationPracticeForm). 

The form is embedded **inside a nested iframe**, and this script is specifically designed to:
- Switch context to the iframe
- Locate and interact with elements inside it
- Remain resilient to layout or attribute changes

---

## Fields Tested
The following fields (within the iframe) are automatically tested:
1. **First Name** – using `placeholder='Name'`
2. **Last Name** – using `placeholder='Surname'`
3. **Gender (Female)** – via radio `input` with ID `female`
4. **Mobile Number** – using `id='mobile'`

---

## Features & Techniques Used
-  **Iframe Switching** using `driver.SwitchTo().Frame(...)`
-  **Robust Element Selection**:
  - By `Id` for stability (`female`, `mobile`)
  - By `XPath` for fields with no unique IDs
-  **Explicit Waits** (`WebDriverWait`) to handle page load timing
-  **Exception Handling** to prevent abrupt crashes

---

## ▶️ How to Run

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [ChromeDriver](https://sites.google.com/chromium.org/driver/)
- NuGet Packages:
  - Selenium.WebDriver
  - Selenium.WebDriver.ChromeDriver
  - Selenium.Support

###  Setup
1. Clone or download this repository.
2. Open the project in Visual Studio **or** use terminal:
   ```bash
   dotnet restore
   dotnet run
