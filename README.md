# Group Array Elements Console Application

This is a console application written in C# that allows you to divide an input array into multiple equally sized subarrays. The code provides a method called `GroupArrayElements`, which takes an input array and the desired number of subarrays, and returns a list of subarrays.

## Installation

To run this console application, please ensure that you have the following prerequisites installed:

- .NET SDK (Software Development Kit): You can download and install the .NET SDK from the official Microsoft website: [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)

## How to Run the Application

Follow these steps to run the console application:

1. Open your command-line interface or terminal.
2. Clone the repository to your local machine
3. Navigate to the directory where the code files are located.
4. Build the code by executing the following command:

```
dotnet build
```
4. Once the build process is complete, run the application using the following command:

 ```
   dotnet run
   ```
6. The application will execute and display the output in the console.

## Usage

The core functionality of the application is implemented in the `GroupArrayElements` method. You can modify the input array `arr` and specify the number of subarrays `N` in the `Main` method to test different scenarios.

The `GroupArrayElements` method divides the input array into N subarrays of equal size. If the size of the array is not evenly divisible by N, the last subarray will contain the remaining elements.

The resulting subarrays are stored in a list of lists (`List<List<int>>`), where each inner list represents a subarray.

The provided sample usage in the `Main` method demonstrates how to use the `GroupArrayElements` method. It creates a sample input array, defines the number of subarrays, and calls the method to obtain the result. The result is then displayed in the console.
