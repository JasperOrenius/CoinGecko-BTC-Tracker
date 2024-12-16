# CoinGecko-BTC-Tracker

A WPF application that displays Bitcoin price and volume data fetched from the CoinGecko API. The app allows users to analyze trends, find the best buying and selling days, and visualize historical Bitcoin data over a specified date range.

## Features

- **Bitcoin Price Analysis**:
  - Displays the highest and lowest prices within a selected date range.
  - Shows the corresponding dates for the highest and lowest prices.
  
- **Trading Volume Insights**:
  - Highlights the days with the highest and lowest trading volumes.
  - Converts trading volumes into Euros for convenience.

- **Trend Analysis**:
  - Calculates the longest bullish (upward) and bearish (downward) trends along with their start and end dates.

- **Profit Optimization**:
  - Identifies the best day to buy Bitcoin and the best day to sell within the selected date range for maximum profit.
  - Similarly, finds the best day to sell first and buy later for minimizing losses.

- **Interactive Chart**:
  - Visualizes historical Bitcoin price data on an interactive chart.

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/CoinGecko-BTC-Tracker.git
   cd CoinGecko-BTC-Tracker

2. **Open the Project in Visual Studio**:
   - Open the `.sln` file using Visual Studio (2022 or later recommended).

3. **Restore Dependencies**:
   - Ensure that NuGet packages are restored. Visual Studio usually handles this automatically.

4. **Build and Run**:
   - Build the project (`Ctrl+Shift+B`) and run the application (`F5`).

## Usage

1. Select a date range using the provided date pickers.
2. Click on the **Fetch Data** button to load Bitcoin price and volume data from the CoinGecko API.
3. View the results:
   - **Price and Volume Statistics**: Displayed in the app's statistics panel.
   - **Trends and Recommendations**: The app calculates and shows the longest trends and optimal buy/sell days.
   - **Chart Visualization**: Historical data is plotted for easy analysis.
4. Hover over the chart to see detailed price data for specific dates.

## Dependencies

- **Newtonsoft.Json**: For parsing JSON data from the CoinGecko API.
- **CoinGecko API**: Data source for Bitcoin prices and trading volumes.
- **WPF Application**: Built on WPF (Windows Presentation Foundation).

## API Information

- The app uses the CoinGecko API's `/market_chart/range` endpoint to fetch data.
- For more details, visit [CoinGecko API Documentation](https://docs.coingecko.com/reference/introduction).
