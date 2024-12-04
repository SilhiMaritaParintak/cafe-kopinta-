// toggle class active 
const navbarNav = document.queryselector('.navbar-nav'):
// ketika hamburger menu di klik
document.querySelector('#hamburger-menu').onclick = () => {
 navbarNav.classList.toggle('active');
}:

// klik di luar sidebar untuk menghasilkan nav
const hamburger = document.queryselector('#hamburger-menu');

document.addEventListener('click', funtion(e) {
 if(!hamburger.contains(e.target)&& !navbarNav.contains(e.target)) {
    navbarNav.classList.remove('active')
 }
});