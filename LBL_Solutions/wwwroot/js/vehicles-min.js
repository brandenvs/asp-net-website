const Vehicles = () => {
    const e = getId("specs"),
        t = getId("controls"),
        i = getId("gallery-prev-s"),
        n = getId("gallery-next-s"),
        s = getId("reveal"),
        o = getId("reveal-video"),
        a = getId("reveal-lines"),
        l = getId("slider"),
        r = getId("reveal-overview"),
        c = queryAll(".js-stagger"),
        d = query(".swiper-dots"),
        p = queryAll(".additional-toggle"),
        g = {
            v: 0
        };
    let v = 0,
        y = 0,
        w = !1;
    const T = () => {
        y = innerHeight, v = s.getBoundingClientRect().top + (HAS_SMOOTH ? SMOOTH_SCROLLING : window.scrollY)
    };
    let x = !1;
    o.pause(), o.currentTime = 0, i.style.opacity = .25, i.style["pointer-events"] = "none";
    const S = {
        el: d,
        type: "bullets",
        clickable: !0
    },
        u = {
            nextEl: n,
            prevEl: i
        },
        M = new Swiper(l, {
            direction: "horizontal",
            loop: !1,
            touchRatio: 2,
            shortSwipes: !0,
            longSwipes: !1,
            simulateTouch: !1,
            autoHeight: !deviceSettings.isDesktop,
            effect: "slide",
            speed: 600,
            pagination: S,
            navigation: u
        }).on("slideChange", e => {
            i.style.opacity = M.isBeginning ? .25 : 1, i.style["pointer-events"] = M.isBeginning ? "none" : "", n.style.opacity = M.isEnd ? .25 : 1, n.style["pointer-events"] = M.isEnd ? "none" : "", deviceSettings.isDesktop && SMOOTH_SCROLLING <= v + y && window.scrollTo(0, v + y)
        });
    new Swiper("#gallery", {
        direction: "horizontal",
        loop: !0,
        speed: 1500,
        navigation: {
            nextEl: "#gallery-next-g",
            prevEl: "#gallery-prev-g"
        },
        on: {
            init: () => decodeImages()
        }
    });
    let h = !1;
    e && e.addEventListener("click", t => {
        t.preventDefault(), h = !h, p[0].style.display = h ? "none" : "table", p[1].style.display = h ? "table" : "none", h ? e.classList.add("active") : e.classList.remove("active")
    }), T(), window.addEventListener("resize", T), TweenMax.ticker.addEventListener("tick", () => {
        const e = HAS_SMOOTH ? SMOOTH_SCROLLING : window.scrollY,
            i = Math.min(y, Math.max(y - (y + v - e), 0));
        TweenMax.set(l, {
            y: `${-y + i}px`
        }), i >= y / 2 ? TweenMax.set(a, {
            opacity: 0
        }) : TweenMax.set(a, {
            opacity: 1,
            clearProps: "opacity"
        }), i >= y - y / 2 ? (TweenMax.set(t, {
            opacity: 1,
            clearProps: "opacity"
        }), deviceSettings.isDesktop && TweenMax.set(r, {
            opacity: 1,
            clearProps: "opacity"
        })) : (TweenMax.set(t, {
            opacity: 0
        }), deviceSettings.isDesktop && TweenMax.set(r, {
            opacity: 0
        })), deviceSettings.isDesktop && (!x && i >= y / 2 && (x = !0, o.currentTime = 0, TweenMax.to(g, .4, {
            v: 1,
            ease: Linear.easeNone,
            onComplete: () => o.play()
        })), x && i < y / 2 && (x = !1, TweenMax.to(g, .4, {
            v: 0,
            ease: Linear.easeNone,
            onComplete: () => {
                o.pause(), o.currentTime = 0
            }
        })), w || i >= .25 * y && (w = !0, TweenMax.staggerFromTo(c, .6, {
            x: 20,
            autoAlpha: 0
        }, {
            x: 0,
            autoAlpha: 1
        }, .2))), 0 !== M.activeIndex && i <= .75 * y && M.slideTo(0, 1e3 * M.activeIndex)
    })
};
"loading" != document.readyState ? Vehicles() : document.addEventListener("DOMContentLoaded", Vehicles);