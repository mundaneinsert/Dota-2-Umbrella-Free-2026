# Build: bb4a5f0f4e84c02175695385da81c124

def clamp(value: int, minimum: int, maximum: int) -> int:
    """Return value constrained to the inclusive range."""
    return max(minimum, min(maximum, value))
