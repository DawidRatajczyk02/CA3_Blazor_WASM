const { test, expect } = require('@playwright/test');

test.describe('Blazor YouTube Search Tests', () => {
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

test.describe('Blazor YouTube Search Pagination Tests', () => {
    test('Should navigate to the next and previous pages', async ({ page }) => {
        // Navigate to app
        await page.goto('https://localhost:7151');

        // Locate the search bar and search button
        const searchBar = page.locator('input[placeholder="Search..."]');
        const searchButton = page.locator('button', { hasText: 'Search' });

        // Perform a search
        await searchBar.fill('mrbeast');
        await searchButton.click();

        // Wait for the search results to appear
        const results = page.locator('.card');
        await expect(results).toHaveCount(6);

        /// Verify the "Previous" button is disabled on the first page
        const previousButton = page.locator('button', { hasText: 'Previous' });
        await expect(previousButton).toBeDisabled();

        // Click the "Next" button
        const nextButton = page.locator('button', { hasText: 'Next' });
        await nextButton.click();

        // Wait for the next page to load and verify the "Previous" button is enabled
        await expect(previousButton).not.toBeDisabled();

        // Verify the "Next" button is still enabled because of 6 pages overall
        await expect(nextButton).not.toBeDisabled();

        // Click the "Previous" button
        await previousButton.click();

        // Verify the "Previous" button is disabled again after returning to the first page
        await expect(previousButton).toBeDisabled();
    });
});