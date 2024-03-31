const splide = new Splide('.splide', {
  drag: true,
  snap: true,
  speed: 1000,
  perMove: 1,
  pagination: true,
  autoWidth: true,
  touchMove: false,
  arrows: false,
  breakpoints: {
    1280: {
      fixedHeight: 809
    },
    768: {
      fixedHeight: 325
    },
    320: {
      fixedHeight: 135
    }
  }
}).mount();