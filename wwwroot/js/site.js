const toggle = document.querySelector('.nav-toggle');
const navigation = document.querySelector('.nav-links');

if (toggle && navigation) {
    toggle.addEventListener('click', () => {
        const isOpen = toggle.getAttribute('aria-expanded') === 'true';
        toggle.setAttribute('aria-expanded', String(!isOpen));
        navigation.classList.toggle('open');
    });
}
