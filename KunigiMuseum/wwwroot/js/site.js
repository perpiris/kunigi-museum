$(document).ready(function () {
    $('.validation-summary-errors, [data-valmsg-for]').each(function () {
        if ($(this).text().length > 0) {
            var inputField = $(this).siblings('input');
            inputField.addClass('is-invalid');
        }
    });

    $('form').on('submit', function () {
        if (!$(this).valid()) {
            $('.input-validation-error').addClass('is-invalid');
        }
    });
    
    $('input').on('input', function() {
        $(this).removeClass('is-invalid');
        $(this).removeClass('input-validation-error');
        $('form').validate().element($(this));
    });
});

function toggleTheme() {
    const html = document.documentElement;
    const currentTheme = html.getAttribute('data-theme');
    const newTheme = currentTheme === 'dark' ? 'light' : 'dark';
    
    html.setAttribute('data-theme', newTheme);
    localStorage.setItem('theme', newTheme);
    
    updateThemeIcon(newTheme);
}

function updateThemeIcon(theme) {
    const icon = document.getElementById('themeIcon');
    if (icon) {
        icon.className = theme === 'dark' ? 'bi bi-moon-fill' : 'bi bi-sun-fill';
    }
}

document.addEventListener('DOMContentLoaded', () => {
    const savedTheme = localStorage.getItem('theme') || 'light';
    document.documentElement.setAttribute('data-theme', savedTheme);
    updateThemeIcon(savedTheme);
});