Overall Design Language
- Minimalist but premium: Clean layouts, generous white space, restrained typography.
- Brand palette:
- Blue #4c6cff
- Pink #ff6cab
- Gold #ffc95e
- Used in animated gradients, hover states, and section accents.
- Motion language:
- animate-gradient-flow for brand gradients.
- animate-fade-in-up for staggered content reveals.
- hover:scale + hover:shadow-lg for tactile card lift.
- Micro‑interactions on icons (scale, rotate, slide).
- Reduced motion: Wrap animations in prefers-reduced-motion media query.

Sections Implemented
Navbar
- Sticky, semi‑transparent with backdrop blur.
- Desktop: inline links with animated gradient underline on hover.
- Mobile: hamburger → close icon toggle, slide‑down menu with smooth scroll.
- Smooth scrolling enabled via scroll-smooth and scroll-mt-20 on sections.
Hero
- Full‑width animated gradient background.
- Headline with gradient‑filled keyword.
- Subtext describing DevOps focus.
- Primary CTA: LinkedIn (animated background shimmer + icon slide).
- Secondary CTA: GitHub (static for now).
- Tech stack tagline below CTAs.
Quick Facts Strip
- Three horizontally aligned facts (years in DevOps, Azure certified, incident reduction).
- Animated gradient bar above each fact.
- Responsive: stacks on mobile.
Skills Section
- DRY loop from a List<Skill>.
- Cards with fade‑in stagger, hover lift, shimmer bar.
Selected Projects
- DRY loop from a List<Project>.
- Cards with fade‑in stagger, hover lift, shimmer bar.
- Top‑right icons with scale/rotate + gradient background animation + icon colour shift.
Timeline (My Journey)
- DRY loop from a List<TimelineItem>.
- Animated gradient spine, coloured markers.
- Fade‑in stagger.
GitHub Projects
- DRY loop from a List<GitHubProject>.
- Repo link (always) + optional live link.
- Link icons with micro‑interaction (scale + nudge).
Footer
- Combined small logo + copyright + minimal links.
- Animated gradient bar above footer content.
404 Page
- Full‑page layout with minimal header/footer.
- Left: friendly message + CTAs (Home, Projects, LinkedIn).
- Right: img/404.png with animated gradient halo + gentle float.
- Matches brand motion and colour language.

Code Conventions
- All repeated content (skills, projects, timeline, GitHub projects) is DRY via lists and loops.
- Animation delays calculated with @(0.1 + (i * 0.1))s for stagger.
- Hover states use brand colours or gradients for consistency.
- Responsive layouts via Tailwind grid and flex utilities.
- Accessibility: meaningful alt text, visible focus states, high contrast.

Next Steps / Ideas
- Optional: Animate GitHub CTA to match LinkedIn shimmer/slide.
- Optional: Add scroll‑triggered animations to Quick Facts.
- Optional: Navbar shrink on scroll for subtle state change.
- Optional: Add “Highlights” strip or metrics to hero for instant credibility.
- Optional: Gradient section dividers for visual continuity.

How to Resume
When we pick this up again:
- Keep this file open as a reference for brand, motion, and code patterns.
- Any new section should:
- Use DRY data → loop pattern.
- Match existing motion language.
- Use brand palette for hover/active states.
- Test on mobile for layout, tap targets, and smooth scroll offsets.
