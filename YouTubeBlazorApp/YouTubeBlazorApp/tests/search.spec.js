const { test, expect } = require('@playwright/test');

test.describe('Blazor YouTube Search Tests', () => {
    // Navigate to the home page
    test('Should display the search bar and perform a search', async ({ page }) => {
        // Navigate to app
        await page.goto('https://localhost:7151');

        // Verify the search bar exists
        const searchBar = page.locator('input[placeholder="Search..."]');
        await expect(searchBar).toBeVisible();

        // Enter a search term
        await searchBar.fill('mrbeast');

        // Click the search button
        const searchButton = page.locator('button', { hasText: 'Search' });
        await searchButton.click();

        // Wait for search results to load
        const results = page.locator('.card-title'); // Target the video title
        await expect(results).toHaveCount(6); // Expect 6 results per page
    });
});
